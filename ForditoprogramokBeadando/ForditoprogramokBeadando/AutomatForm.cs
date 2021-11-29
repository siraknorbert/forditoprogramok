using ForditoprogramokBeadando.Automat;
using ForditoprogramokBeadando.Automat.Exceptions;
using ForditoprogramokBeadando.Automat.Rules;
using ForditoprogramokBeadando.FileReaders.Implementations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForditoprogramokBeadando
{
    /// <summary>
    /// Main form code of the application.
    /// </summary>
    public partial class AutomatForm : Form
    {
        // Automat instance
        private StackAutomat automatInstance;

        // Combobox elements
        private readonly string CBMockedReader = "mocked";
        private readonly string CBTxtReader = "txt";

        /// <summary>
        /// Init form.
        /// </summary>
        public AutomatForm()
        {
            InitializeComponent();

            try
            {
                automatInstance = StackAutomat.SingletonInstance();
                InitReaderComboBoxOptions();
                InitRulesDataGridView();
                resultRichTextBox.ReadOnly = true;
            }
            catch (AutomatException ex)
            {
                ShowMessage(ex.Message);
            }
            catch (Exception)
            {
                ShowMessage();
            }
        }

        /// <summary>
        /// Initialize combo box of file readers.
        /// </summary>
        private void InitReaderComboBoxOptions()
        {
            readerComboBox.Items.Add(CBMockedReader);
            readerComboBox.Items.Add(CBTxtReader);
            readerComboBox.SelectedItem = CBMockedReader;
        }

        /// <summary>
        /// Initialize data grid view of rules.
        /// </summary>
        private void InitRulesDataGridView()
        {
            string[] terminalSymbols = Symbols.TerminalSymbols;
            string[] nonTerminalSymbols = Symbols.NonTerminalSymbols;
            rulesDataGridView.ReadOnly = true;

            for (int i = 0; i < terminalSymbols.Length; i++)
            {
                rulesDataGridView.Columns.Add("c" + i.ToString(), terminalSymbols[i]);
                rulesDataGridView.Columns[i].Width = (rulesDataGridView.Size.Width / nonTerminalSymbols.Length) - 35;
            }

            for (int i = 0; i < nonTerminalSymbols.Length; i++)
            {
                rulesDataGridView.Rows.Add();
                rulesDataGridView.Rows[i].HeaderCell.Value = nonTerminalSymbols[i];
                rulesDataGridView.Rows[i].Height = (rulesDataGridView.Size.Height / terminalSymbols.Length) - 6;
            }

            LoadRulesIntoDataGridView();
        }

        /// <summary>
        /// Loads the rules stored in the rule container into the data grid.
        /// </summary>
        private void LoadRulesIntoDataGridView()
        {
            Rule[,] rules = automatInstance.Rules;

            for (int r = 0; r < Symbols.NonTerminalSymbols.Length; r++)
            {
                for (int c = 0; c < Symbols.TerminalSymbols.Length; c++)
                {
                    if (rules[r, c] == null || Equals(rules[r, c].ToString(), ""))
                    {
                        rulesDataGridView.Rows[r].Cells[c].Value = "";
                    }
                    else
                    {
                        if (Equals(rules[r, c].Symbol, ""))
                        {
                            rulesDataGridView.Rows[r].Cells[c].Value = new Rule("e", rules[r, c].Number).ToString();
                        }
                        else
                        {
                            rulesDataGridView.Rows[r].Cells[c].Value = rules[r, c].ToString();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Validate input on validation button click event.
        /// </summary>
        private void validateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;

            try
            {
                if (input.Length == 0 || input is null)
                {
                    throw new InputException("Input tape is empty!");
                }

                resultRichTextBox.Text = automatInstance.ValidateInput(input);
                ShowMessage("Input is valid.", false);
            }
            catch (AutomatException ex)
            {
                ShowMessage(ex.Message);
            }
            catch (Exception)
            {
                ShowMessage();
            }
        }

        /// <summary>
        /// Change file reader implementation.
        /// </summary>
        private void readerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string readerImpl = readerComboBox.Text;

            if (Equals(readerImpl, CBTxtReader))
            {
                automatInstance.FileReader = new TxtReader();
            }
            else
            {
                automatInstance.FileReader = new MockedReader();
            }
        }

        /// <summary>
        /// Read rules from external file.
        /// </summary>
        private void readRulesButton_Click(object sender, EventArgs e)
        {
            try
            {
                automatInstance.ReadRules(pathTextBox.Text, fileTextBox.Text);
                LoadRulesIntoDataGridView();
            }
            catch (AutomatException ex)
            {
                ShowMessage(ex.Message);
            }
            catch (Exception)
            {
                ShowMessage("Invalid path or file name!");
            }
        }

        /// <summary>
        /// Display status message - mainly for errors.
        /// </summary>
        /// <param name="msg">Text of message.</param>
        /// <param name="isError">Bool that decides the color of text.</param>
        private void ShowMessage(string msg = "Unknown error occured.", bool isError = true)
        {
            if (isError)
            {
                messageLabel.ForeColor = Color.Red;
            }
            else
            {
                messageLabel.ForeColor = Color.Green;
            }

            messageLabel.Text = msg;
        }
    }
}
