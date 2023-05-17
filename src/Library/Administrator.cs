using System;

namespace Proyect;

public class Administrator : Person
{
    public Administrator () : base(string name, int id, string address, int phoneNumber)
    {

    }

    public void AddCategory(Category category)
    {
        //Lógica para añadir una categoria
    }
    
    public void RemoveCategory(int identifier)
    {
        // Lógica para eliminar una categoría 
    }

    public void RemoveRefuge(int identifier)
    {
        // Lógica para eliminar un refugio 
    }

}