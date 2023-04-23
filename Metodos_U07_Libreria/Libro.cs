namespace Metodos_U07_Libreria
{
    public class Libro
    {
        private List<string> paginas;

        /// <summary>
        /// Crea una nueva instancia de la clase Libro y inicializa la lista de páginas.
        /// </summary>
        public Libro()
        { 
            paginas = new List<string>();
        }

        /// <summary>
        /// Permite acceder a una página del libro mediante un índice.
        /// </summary>
        /// <param name="i">Índice de la página.</param>
        /// <returns>Devuelve el contenido de la página o una cadena vacía si el índice está fuera de rango.</returns>
        public string this[int i] // Indexador
        {
            get
            {
                if (i >= 0 && i < paginas.Count)
                {
                    return paginas[i];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (i >= paginas.Count)
                {
                    paginas.Add(value);
                }
                else
                {
                    paginas[i] = value;
                }
            }
        }
        
    }
}