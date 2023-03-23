using Asp___Angular_2.Services;
using Asp___Angular_2.Model;
using Microsoft.AspNetCore.Mvc;

namespace Asp___Angular_2.Controllers;

[ApiController]
[Route("[controller]")]
public class EmpleadoController : ControllerBase
{
    EmpleadoService _service;
    
    public EmpleadoController(EmpleadoService service)
    {
        _service = service;
    }

    [HttpGet("GetAll")]
    public IEnumerable<Empleado> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("telefono")]
    public IEnumerable<Num_telefono> GetTel()
    {
        return _service.GetTel();
    }


    [HttpGet("GetById/{id}")]
    public ActionResult<Empleado> GetById(int id)
    {
        var empleado = _service.GetById(id);

        if(empleado is not null)
        {
            return empleado;
        }
        else
        {
            return NotFound();
        }
    }

        [HttpGet("telefono/{id}")]
        public ActionResult<Num_telefono> GetTelId(int id)
    {
        var telefono = _service.GetTelId(id);

        if(telefono is not null)
        {
            return telefono;
        }
        else
        {
            return NotFound();
        }
    }


    [HttpPost("Create")]
    public IActionResult Create(Empleado newEmpleado)
    {
        var empleado = _service.Create(newEmpleado);
        return CreatedAtAction(nameof(GetById), new { id = empleado!.Id }, empleado);
    }

    [HttpPost("telefono")]
    public IActionResult CreateTelefono(Num_telefono newTelefono){
        var telefono = _service.CreateTel(newTelefono);
        return CreatedAtAction(nameof(GetById), new { id = telefono!.TelefonoId }, telefono);
    }

    [HttpDelete("telefono/{id}")]
    public IActionResult telefono(int id){
        var telefono = _service.GetTelId(id);
          if(telefono is not null)
        {
            _service.DeleteTel(id);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
    [HttpDelete("Delete/{id}")]
    public IActionResult Delete(int id)
    {
        var empleado = _service.GetById(id);

        if(empleado is not null)
        {
            _service.DeleteById(id);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}