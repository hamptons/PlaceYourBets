using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace PlaceYourBets
{
	public class UserList
	{

		public List<Users> stock {
			get { return m_stock; }
			set { m_stock = value; }
		}
		private List<Users> m_stock;
		public int success {
			get { return m_success; }
			set { m_success = value; }
		}

		private int m_success;
	}
}
