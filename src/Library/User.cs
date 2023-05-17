using System;

namespace Proyect;

public class User:Person
{
    public User () : base(string name, int id, string address, int phoneNumber)
    {

    }

    public void LookingForShelter(Shelter Shelter)
    {
        //Lógica para buscar un refugio
    }

    public void ShelterResult()
    {
        //Lógica para mostrarle al usuario los refugios ordenados por ubicacion
    }

    public void Contact(Shelter Shelter)
    {
        // Lógica para establecer contacto con el refugio proporcionado
    }

    public void QualifyShelter(int rating, Shelter Shelter)
    {
        // Lógica para calificar el refugio con la calificación proporcionada
    }

    public void ModifyUserData()
    {
        // Lógica para modificar los datos del usuario
    }
}