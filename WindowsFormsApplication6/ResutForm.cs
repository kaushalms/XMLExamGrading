using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace WindowsFormsApplication6
{
    public partial class ResutForm : Form
    {

        public ResutForm()
        {
            InitializeComponent();


            XMLDoc.Load("result.xml");
            var allElements = XMLDoc.SelectNodes("//*");

            YA1.Text = getValue("/Test[1]/Test[1]/Multiple_choice_1[1]");
            YA2.Text = getValue("/Test[1]/Test[1]/Multiple_choice_2[1]");
            YA3.Text = getValue("/Test[1]/Test[1]/Multiple_choice_3[1]");
            YA4.Text = getValue("/Test[1]/Test[1]/Multiple_choice_4[1]");
            YA5.Text = getValue("/Test[1]/Test[1]/Essay_Answer[1]");
           label5.Text = getValue("/Test[1]/Test[1]/grammarMistake[1]");
           label6.Text = getValue("/Test[1]/Test[1]/spellingMistake[1]");
            score.Text = getValue("/Test[1]/Test[1]/Total_Score[1]");
        }


        String XMLFile = "";
        ArrayList xpathList = new ArrayList();
        XmlDocument XMLDoc = new XmlDocument();

        public String getValue(String xpath)
        {

            try
            {
                XPathDocument document = new XPathDocument("result.xml");
                string queryString = xpath.ToString();

                XPathNavigator navigator = document.CreateNavigator();
                XPathNodeIterator nodes2 = navigator.Select(queryString);
                String innerString = String.Empty;
                while (nodes2.MoveNext())
                {
                    return (innerString = (innerString + nodes2.Current.InnerXml));
                }
                return "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }

        }

       

    }
}