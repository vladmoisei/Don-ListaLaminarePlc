using ItroducereDateCuptor;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducereDateCuptor
{
    public class ListaHub : Hub
    {
        public async Task ActualizareListaClienti(List<Blum> listaActualizata) 
        {

            await Clients.All.SendAsync("show_data", listaActualizata);
        }
    }
}
