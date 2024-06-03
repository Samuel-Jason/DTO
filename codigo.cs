[HttpGet]
[Route("{id}")]
public IActionResult Search(int id)
{
    _logger.Log(LogLevel.Error, "Teve um Erro");
    var employees = _employeeRepository.Get(id);
    var employeesDTOS = _mapper.Map<EmployeeDTO>(employees);
    _logger.LogInformation("Teste");
    return Ok(employeesDTOS);
}
