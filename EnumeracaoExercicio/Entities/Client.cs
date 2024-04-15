namespace EnumeracaoExercicio.Entities
{
    class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public DateOnly BirthDate { get; set; }
        public Client() { }
        public Client(string name, string email, DateOnly birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
