namespace search_algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Convertir la lista de n�meros ingresada en un array
            int[] numbers;
            try
            {
                numbers = txtNumbers.Text.Split(',')
                                           .Select(int.Parse)
                                           .ToArray();
            }
            catch
            {
                MessageBox.Show("Ingrese una lista v�lida de n�meros separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Leer el n�mero a buscar
            if (!int.TryParse(txtSearch.Text, out int key))
            {
                MessageBox.Show("Ingrese un n�mero v�lido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = -1;

            // Determinar el m�todo de b�squeda seleccionado
            if (rbtnSequential.Checked)
            {
                result = SearchAlgorithms.SequentialSearch(numbers, key);
            }
            else if (rbtnBinary.Checked)
            {
                result = SearchAlgorithms.BinarySearch(numbers, key);
            }
            else if (rbtnHash.Checked)
            {
                result = SearchAlgorithms.HashSearch(numbers, key);
            }
            else
            {
                MessageBox.Show("Seleccione un m�todo de b�squeda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar el resultado
            if (result != -1)
            {
                lblResult.Text = $"N�mero encontrado en la posici�n: {result}";
            }
            else
            {
                lblResult.Text = "N�mero no encontrado.";
            }
        }
    }
}
