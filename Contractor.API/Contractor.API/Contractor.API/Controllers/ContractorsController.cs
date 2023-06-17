using Contractor.API.Dtos;
using Contractor.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Contractor.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ContractorsController : ControllerBase
    {
        private readonly IContractorRepository _contractorRepository;

        public ContractorsController(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entities.Contractor>>> GetAll()
        {
            var contractors = await _contractorRepository.GetAllAsync();

            return Ok(contractors);
        }

        [HttpGet("{contractorId}")]
        public async Task<ActionResult<ContractorDto>> GetContractor(Guid contractorId)
        {
            var contractor = await _contractorRepository.GetAsync(contractorId);

            if (contractor == null)
            {
                return NotFound();
            }

            return Ok(contractor);
        }
    }
}
