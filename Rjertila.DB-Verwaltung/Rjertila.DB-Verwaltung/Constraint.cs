namespace Rjertila.DB_Verwaltung;

public class Constraint
    {
      public string Bezeichner { get; set; }
      public string Definition { get; set; }

        public Constraint(string bezeichner, string definition)
        {
            Bezeichner = bezeichner;
            Definition = definition;
        }
}

