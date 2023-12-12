namespace BattleSimCharacterManager
{
    public partial class Form1 : Form
    {
        string currentCharList = string.Empty;
        List<Character> loadedChars = new List<Character>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadCharacterListFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YamlDotNet.Serialization.Deserializer deserializer = new YamlDotNet.Serialization.Deserializer();
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                currentCharList = fileDialog.FileName;
                loadedChars = deserializer.Deserialize<List<Character>>(currentCharList);

                foreach (Character character in loadedChars)
                {
                    charSelectBox.Items.Add(character.name);
                }
            }
        }

        private void charSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character selectedChar = new Character();
            foreach (Character character in loadedChars)
            {
                if (character.name == (string)charSelectBox.SelectedItem)
                {
                    selectedChar = character;
                    nameBox.Text = character.name;
                    minDmgBox.Value = character.minDamage;
                    maxDmgBox.Value = character.maxDamage;
                    healCheckBox.Checked = character.healer;
                    minHealBox.Value = character.minHealing;
                    maxHealBox.Value = character.maxHealing;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Character character = new Character();
        }
    }
}
