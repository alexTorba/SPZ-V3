using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Threading;
using System.Xml.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Lb6
{
	[Serializable]
	public class Factory
	{
		int m_departmentAmount;
		int m_rawAmount;
		int m_finalProductAmount;
		int m_moneyAmount;
		int m_storage;

		private int Money
		{
			get => m_moneyAmount;

			set
			{
				if (value < 0)
					throw new ArgumentException("Money amount can't be less than zero!");

				m_moneyAmount = value;
			}
		}

		private int Raw
		{
			get => m_rawAmount;

			set
			{
				if (value < 0)
					throw new ArgumentException("Raw amount can't be less than zero!");

				m_rawAmount = value;
			}
		}

		private int Product
		{
			get => m_finalProductAmount;

			set
			{
				if (value < 0)
					throw new ArgumentException("Product amount can't be less than zero!");

				m_finalProductAmount = value;
			}
		}

		private int Department
		{
			get => m_departmentAmount;

			set
			{
				if (value < 0)
					throw new ArgumentException("Department amount can't be less than zero!");

				m_departmentAmount = value;
			}
		}
		private int Storage
		{
			get => m_storage;

			set
			{
				if (value < 0)
					throw new ArgumentException("Storage less than zero!");

				if (m_storage + value > 100)
					return;

				m_storage = value;
			}
		}
		public Factory()
		{
			Money = 1000; // start capital
			Raw = 500;
			Product = 15;
			Department = 10;
			Storage = 100;
		}

		public void buyRaw()
		{
			Console.WriteLine("Buying some raw materials...");
			Thread.Sleep(2000);
			Money -= 200;
			Storage -= 5;
			Raw += 500;
			saveResult("Buyig raw materials");
			Console.WriteLine("Bought succesfully");
		}

		public void makeProduct()
		{
			Console.WriteLine("Making product...");
			Thread.Sleep(5000);
			Money -= 150;
			Storage += 1;
			Raw -= 1;
			Product += 10;
			saveResult("Making product");
			Console.WriteLine("Product was made succesfully");
		}

		public void sellProduct()
		{
			Console.WriteLine("Selling product...");
			Thread.Sleep(3000);
			Product -= 10;
			Money += 500;
			Storage -= 1;
			saveResult("Selling");
			Console.WriteLine("Sold product succesfully");
		}

		public void runCicle()
		{
			Thread t = new Thread(
				() =>
				{
					buyRaw();
					makeProduct();
					sellProduct();
				}
			);
			t.Start();
		}

		public void runParallel()
		{
			Thread buyThread = new Thread(
				() =>
				{
					buyRaw();
				}
			);

			Thread ProductThread = new Thread(
				() =>
				{
					makeProduct();
				}
			);

			Thread SellThread = new Thread(
				() =>
				{
					sellProduct();
				}
			);

			buyThread.Start();
			ProductThread.Start();
			SellThread.Start();
		}

		private void saveResult(string _message)
		{
			XDocument doc = new XDocument();

			XElement el = new XElement("Stage"
				,	new XAttribute("Name", _message)
						,	new XElement("Money", Money)
						,	new XElement("Raw_amount", Raw)
						,	new XElement("Storage", Storage)
						,	new XElement("Product", Product)
			);

			var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//FactoryOverview.xml";

			if (File.Exists(path))
			{
				doc = XDocument.Load(path);
				doc.Element("Alexey228").Add(el);
			}
			else
				doc = new XDocument(new XElement("Alexey228", el));

			doc.Save(path);
		}

	}
}
