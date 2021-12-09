public class Person {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string DNI { get; set; }
        public string Marstatus { get; set; }

        public Person()
        {
            
        }
        public Person(string name, string surname, string age, string dni, string marstatus){
            Name = name;
            Surname= surname;
            Age = age;
            DNI = dni;
            Marstatus = marstatus;
        }

        public string FullName()
        {
            return $"Nombre:{Name}\napellido:{Surname} \nEdad:{Age} \nDNI:{DNI} \nEstado Civil:{Marstatus}";
        }

}