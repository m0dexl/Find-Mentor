using Business.Services.Base.Interface;
using Core.Results;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Base;
public abstract class BaseCRUDController<TEntity, TId, TCreateDTO,TUpdateDTO, TResponseDTO> : BaseController
    where TEntity : class
    where TCreateDTO : class
    where TUpdateDTO : class
    where TResponseDTO : class
{
    protected readonly IBaseService<TEntity, TId, TResponseDTO> _service;

    public BaseCRUDController(IBaseService<TEntity, TId, TResponseDTO> service)
    {
        _service = service;
    }

    [HttpGet]
    public virtual async Task<ActionResult<DataResult<IList<TResponseDTO>>>> GetAll()
        => await _service.GetAllAsync();

    [HttpGet]
    public virtual async Task<ActionResult<DataResult<TResponseDTO>>> GetById(TId id)
        => await _service.GetByIdAsync(id);

    [HttpPost]
    public virtual async Task<ActionResult<Result>> Create([FromBody] TCreateDTO requestDto)
        => await _service.AddFromDtoAsync(requestDto);

    [HttpPut]
    public virtual async Task<ActionResult<Result>> Update(TId id,[FromBody] TUpdateDTO requestDto)
        => await _service.UpdateAsync(id,requestDto);

    [HttpDelete]
    public virtual async Task<ActionResult<Result>> Delete(TId id)
        => await _service.DeleteAsync(id);
}

