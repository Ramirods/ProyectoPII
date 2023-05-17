using System;

namespace Proyect;

public class Service
{
    public string ServiceName { get; set; }

    public Service(string serviceName)
    {
        this.ServiceName = serviceName
    }

    public void AddService()
    {
        // Lógica para agregar un servicio
    }

    public void RemoveService()
    {
        // Lógica para eliminar un servicio
    }
}