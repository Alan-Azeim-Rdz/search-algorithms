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
            // Convertir la lista de números ingresada en un array
            int[] numbers;
            try
            {
                numbers = txtNumbers.Text.Split(',')
                                           .Select(int.Parse)
                                           .ToArray();
            }
            catch
            {
                MessageBox.Show("Ingrese una lista válida de números separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Leer el número a buscar
            if (!int.TryParse(txtSearch.Text, out int key))
            {
                MessageBox.Show("Ingrese un número válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = -1;

            // Determinar el método de búsqueda seleccionado
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
                MessageBox.Show("Seleccione un método de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar el resultado
            if (result != -1)
            {
                lblResult.Text = $"Número encontrado en la posición: {result}";
            }
            else
            {
                lblResult.Text = "Número no encontrado.";
            }
        }
    }
}
