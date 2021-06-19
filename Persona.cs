namespace MiPrimerConsola
{
    class Persona
    {
        //encapsulamiento
        string nombre;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get; set; }
        public float Nota { get; set; }
        public int Peso { get; set; }
        public int Edad { get; set; }

        public string NombreCompleto
        {
            get { return $"{this.Nombre} {this.Apellido}"; }//interpolacion
        }

        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Saludar()
        {
            return $"hola... ¿cómo estas?, mi nombre es {this.Nombre}";
        }   
        
    }
}
