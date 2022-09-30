using System.Collections.Generic;

namespace OOP_App.ContentContext
{
    public class Career : Content
    {
        // Como estamos trabalhando com uma lista precisamos inicializar ela
        public Career(string title, string url)
        : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        
        // Então a nossa carreira em si n vai ter uma lista de cursos e sim uma lista de itens de carreira
        public IList<CareerItem> Items { get; set; }
        
        // Essa proprieade vai servir pra contar a quantidade de itens 'cursos' que nós temos
        // Essa prop nós nunca vamos atribuir nada, retiramos o set
        // Pq ele só irá contar a quantidade de itens
        // Como só temos uma linha no get podemos usar essa expression body pra atribuir o get
        public int TotalCourses => Items.Count; 
        /*{
            get
            {
                return Items.Count;
            }
        }*/
    }
}