using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Athur A. Ferreira", "857.032.950-41", "arthur.antune@sp,senai.br","Madruga");
        Cliente cliente2 = new Cliente(02, "Linux nikton Bug", "765.233.234-67", "LInux.nikton@senai.br","osint");
        Cliente cliente3 = new Cliente(03, "Nmap Window", "432.544.868-65", "NmapWindowa@sp,senai.br","Bug");
        Cliente cliente4 = new Cliente(04, "Mrrobot Hopper", "857.032.950-41", "mrRobot@sp,senai.br","HTML");
        Cliente cliente5 = new Cliente(05, "Kali linux ", "745.234.098-12", "KaliLinux@sp,senai.br","SQL Injection");
   
        List<Cliente> listaClientes = new List<Cliente>();
        listaCliente.Add(Cliente1);
        listaCliente.Add(Cliente2);
        listaCliente.Add(Cliente3);
        listaCliente.Add(Cliente4);
        listaCliente.Add(Cliente5);

        ViewBag.listaClientes = listaClientes;

        Cliente fornecedor1 = new Fornecedor(01, "Athur1 A. Ferreira", "857.032.950-41", "arthur.antune@sp,senai.br","Madruga");
        Cliente fornecedor2 = new Fornecedor(02, "Linux2 nikton Bug", "765.233.234-67", "LInux.nikton@senai.br","osint");
        Cliente fornecedor3 = new Fornecedor(03, "Nmap3 Window", "432.544.868-65", "NmapWindowa@sp,senai.br","Bug");
        Cliente fornecedor4 = new Fornecedor(04, "Mrrobot4 Hopper", "857.032.950-41", "mrRobot@sp,senai.br","HTML");
        Cliente fornecedor5= new Fornecedor(05, "Kali linux5 ", "745.234.098-12", "KaliLinux@sp,senai.br","SQL Injection");

           List<Fornecedor> listaFornecedores = new List<Fornecedor>();


        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(Cliente1);
        listaFornecedores.Add(Cliente2);
        listaFornecedores.Add(Cliente3);
        listaFornecedores.Add(Cliente4);
        listaFornecedores.Add(Cliente5);


        ViewBag.listaForncedores = listaFornecedores;
      








        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
