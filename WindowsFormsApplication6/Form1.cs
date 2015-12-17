using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using System.Reflection;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        String XMLFile = "";
        ArrayList xpathList = new ArrayList();
        XmlDocument XMLDoc = new XmlDocument();
        double score = 0;
        double essay_score = 0;
        int spellingMistakes = 0;
        int grammaticalErrors = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadExam_Click(object sender, EventArgs e)
        {
            try
            {
               

                LoadXml("test.xml");
                XMLDoc.Load("test.xml");
                var allElements = XMLDoc.SelectNodes("//*");

               

                Q1A.Text = getValue("/test[1]/multipleChoice[1]/Option1[1]");
                Q1B.Text = getValue("/test[1]/multipleChoice[1]/Option2[1]");
                Q1C.Text = getValue("/test[1]/multipleChoice[1]/Option3[1]");
                Q1D.Text = getValue("/test[1]/multipleChoice[1]/Option4[1]");

                Q2A.Text = getValue("/test[1]/multipleChoice[2]/Option1[1]");
                Q2B.Text = getValue("/test[1]/multipleChoice[2]/Option2[1]");
                Q2C.Text = getValue("/test[1]/multipleChoice[2]/Option3[1]");
                Q2D.Text = getValue("/test[1]/multipleChoice[2]/Option4[1]");

                Q3A.Text = getValue("/test[1]/multipleChoice[3]/Option1[1]");
                Q3B.Text = getValue("/test[1]/multipleChoice[3]/Option2[1]");
                Q3C.Text = getValue("/test[1]/multipleChoice[3]/Option3[1]");
                Q3D.Text = getValue("/test[1]/multipleChoice[3]/Option4[1]");

                Q4A.Text = getValue("/test[1]/multipleChoice[4]/Option1[1]");
                Q4B.Text = getValue("/test[1]/multipleChoice[4]/Option2[1]");
                Q4C.Text = getValue("/test[1]/multipleChoice[4]/Option3[1]");
                Q4D.Text = getValue("/test[1]/multipleChoice[4]/Option4[1]");

                groupBox1.Text = getValue("/test[1]/multipleChoice[1]/Question[1]");
                groupBox2.Text = getValue("/test[1]/multipleChoice[2]/Question[1]");
                groupBox3.Text = getValue("/test[1]/multipleChoice[3]/Question[1]");
                groupBox4.Text = getValue("/test[1]/multipleChoice[4]/Question[1]");

                label1.Text = getValue("/test[1]/essay[1]/Question[1]");



            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Plese select a valid file" + ex);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Load the exam");
            }

        }


        public string GetXPathToNode(XmlNode node)
        {
            if (node.NodeType == XmlNodeType.Attribute)
            {

                return String.Format("{0}/@{1}", GetXPathToNode(((XmlAttribute)node).OwnerElement), node.Name);
            }
            if (node.ParentNode == null)
            {

                return "";
            }


            int indexInParent = 1;
            XmlNode siblingNode = node.PreviousSibling;

            while (siblingNode != null)
            {

                if (siblingNode.Name == node.Name)
                {
                    indexInParent++;
                }
                siblingNode = siblingNode.PreviousSibling;
            }

            return String.Format("{0}/{1}[{2}]", GetXPathToNode(node.ParentNode), node.Name, indexInParent);
        }




        private void LoadXml(string FILE_NAME)
        {
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} does not exist.", FILE_NAME);
                return;
            }
            StreamReader sr = File.OpenText(FILE_NAME);
            String input;

            input = sr.ReadToEnd();
            sr.Close();
            XMLFile = input;

        }



        public String getValue(String xpath)
        {

            try
            {
                XPathDocument document = new XPathDocument("test.xml");
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


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                essay_score = 0;
                ScoreEssay();
                //MessageBox.Show("Your score is " + score);

                var checkedButton1 = groupBox1.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);

                string ch1 = checkedButton1.Text;
                if (ch1 == "Dimension")
                {
                    Console.Write(ch1);
                    score += 2.5;
                }
                var checkedButton2 = groupBox2.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);

                string ch2 = checkedButton2.Text;
                if (ch2 == "Combines structure and data")
                {
                    Console.Write(ch2);
                    score += 2.5;
                }
                var checkedButton3 = groupBox3.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);

                string ch3 = checkedButton3.Text;
                if (ch3 == "Poor performance")
                {
                    Console.Write(ch3);
                    score += 2.5;
                }
                var checkedButton4 = groupBox4.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);

                string ch4 = checkedButton4.Text;
                if (ch4 == "Select Roots")
                {
                    Console.Write(ch4);
                    score += 2.5;
                }


                XmlTextWriter writer = new XmlTextWriter("result.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Test");
                createNode(ch1, ch2, ch3, ch4, textBox1.Text, "" + score, writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                Console.Write("XML File created ! ");

                string path = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\test.xml";

                Console.Write(path);

                this.Hide();
                ResutForm resultform = new ResutForm();
                resultform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please answer all the questions.");
            }

        }

        private void ScoreEssay()
        {
            ArrayList keywords= new ArrayList{
            "xml", "document","path","structure","library","functions", "xslt", "xquery", "w3c","standard"};

            String[] answerWords = textBox1.Text.Split(' ','.',',');
            foreach (String word in answerWords)
            {
                Console.Write(word);
                foreach (String key in keywords)
                {
                    if (Regex.IsMatch(word.ToLower(), key.ToLower()))
                        essay_score+=0.5;
                }
            }

            if (essay_score >= 5)
                score += 5;
            else
                score += essay_score;

            spellingMistakes = CheckSpelling(textBox1.Text);
            grammaticalErrors = CheckGrammar(textBox1.Text);
            Console.Write("grammar: " + grammaticalErrors);
            Console.Write("spellmistake: " + spellingMistakes);
            if (spellingMistakes > 1 && spellingMistakes < 3)
                score -= 1;
            if (spellingMistakes > 3)
                score -= 2;
            if (grammaticalErrors > 1 && grammaticalErrors < 3)
                score -= 1;
            if (grammaticalErrors > 3)
                score -= 2;
          
        }

        private void createNode(string M1, string M2, string M3, string M4, string essay, string TotalScore, XmlTextWriter writer)
        {
            writer.WriteStartElement("Test");
            writer.WriteStartElement("Multiple_choice_1");
            writer.WriteString(M1);
            writer.WriteEndElement();
            writer.WriteStartElement("Multiple_choice_2");
            writer.WriteString(M2);
            writer.WriteEndElement();
            writer.WriteStartElement("Multiple_choice_3");
            writer.WriteString(M3);
            writer.WriteEndElement();
            writer.WriteStartElement("Multiple_choice_4");
            writer.WriteString(M4);
            writer.WriteEndElement();
            writer.WriteStartElement("Essay_Answer");
            writer.WriteString(essay);
            writer.WriteEndElement();
            writer.WriteStartElement("grammarMistake");
            writer.WriteString(""+grammaticalErrors);
            writer.WriteEndElement();
            writer.WriteStartElement("spellingMistake");
            writer.WriteString("" + spellingMistakes);
            writer.WriteEndElement();
            writer.WriteStartElement("Total_Score");
            writer.WriteString("" + TotalScore);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        private int CheckGrammar(string essay)
        {

            bool grammarErrors = false;
            int gramErrors = 0;
            Word.Application app = new Word.Application();
            if (textBox1.Text.Length > 0)
            {
                grammarErrors = app.CheckGrammar(essay);
                if (grammarErrors == true)
                {
                    
                    gramErrors++;
                }
            }
            return gramErrors;
        }


        private string[] GetSynonyms(Microsoft.Office.Interop.Word.Application wordApp, string word, int maxSize = 20, bool addOriginal = false)
        {
            List<string> synonymArray = new List<string>();
            if (addOriginal) synonymArray.Add(word);
            SynonymInfo synonyms = wordApp.SynonymInfo[word];
            foreach (var Meaning in synonyms.MeaningList as Array)
            {
                if (synonymArray.Contains(Meaning) == false) synonymArray.Add((string)Meaning);
            }
            for (int ii = 0; ii < synonymArray.Count; ii++)
            {
                synonyms = wordApp.SynonymInfo[synonymArray[ii]];
                foreach (string Meaning in synonyms.MeaningList as Array)
                {
                    if (synonymArray.Contains(Meaning)) continue;
                    synonymArray.Add(Meaning);
                }
                if (synonymArray.Count >= maxSize) return synonymArray.ToArray();
            }
            return synonymArray.ToArray();
        }


        private int CheckSpelling(string essay)
        {
            int violations = 0;
            Word.Application app = new Word.Application();
            if (textBox1.Text.Length > 0)
            {
                app.Visible = false;
                object template = Missing.Value;
                object newTemplate = Missing.Value;
                object documentType = Missing.Value;
                object visible = true;
                object optional = Missing.Value;
                _Document doc = app.Documents.Add(ref template,
                   ref newTemplate, ref documentType, ref visible);
                doc.Words.First.InsertBefore(textBox1.Text);
                Word.ProofreadingErrors we = doc.SpellingErrors;
                violations = we.Count;
               
                object first = 0;
                object last = doc.Characters.Count - 1;
                textBox1.Text = doc.Range(ref first, ref last).Text;
            }
           
            return violations;
        }




        //Q1 Answer is Dimensions

        private void Q1A_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q1B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q1C_CheckedChanged(object sender, EventArgs e)
        {
            //score += 2.5;

        }

        private void Q1D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q2Label_Click(object sender, EventArgs e)
        {

        }
        //Q2 Answer is combines structure and data
        private void Q2A_CheckedChanged(object sender, EventArgs e)
        {
            //score += 2.5;
        }

        private void Q2B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q2C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q2D_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Q3 answer is poor performance
        private void Q3label_Click(object sender, EventArgs e)
        {

        }

        private void Q3D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q3C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q3B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q3A_CheckedChanged(object sender, EventArgs e)
        {
            //score += 2.5;
        }
        //Select Roots
        private void Q4label_Click(object sender, EventArgs e)
        {

        }

        private void Q4A_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q4B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q4C_CheckedChanged(object sender, EventArgs e)
        {
            //score += 2.5;
        }

        private void Q4D_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Upper;



        }
    

        
    }
}
