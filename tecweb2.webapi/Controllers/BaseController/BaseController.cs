using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tecweb2.webapi.Helpers.Exceptions;

namespace tecweb2.webapi.Controllers.BaseController
{
    public class BaseController : Controller
     {

         /// <summary>
        ///     Run <paramref name="predicate" /> under default statement.
        /// </summary>
        /// <param name="predicate">Function to be ran.</param>
        /// <returns><paramref name="predicate" /> return or default return in case of an error has been thrown.</returns>
        protected async Task<IActionResult> RunDefaultAsync(Func<Task<IActionResult>> predicate)
        {
            if (!ModelState.IsValid)
            {
                return InvalidModel();
            }

            try
            {
                return await predicate();
            }
            catch (InvalidArgumentException invalidArgumentException)
            {
                return BadRequest(new ParamError
                {
                    Code = invalidArgumentException.Code,
                    Param = invalidArgumentException.ParamName,
                    Message = invalidArgumentException.Message
                });
            }
            catch (Exception exception)
            {
                return StatusCode(500, new Error
                {
                    Code = 0,
                    Message = exception.Message
                });
            }
        }

        private IActionResult InvalidModel()
        {
            var errors = new Error();
            errors.Code = (int) ExceptionEnum.ErrorParam;
            errors.Message = ModelState.Values.FirstOrDefault()?.Errors.FirstOrDefault()?.ErrorMessage;
            return BadRequest(errors);
        }

        /// <summary>
        ///     Run <paramref name="predicate" /> under default statement.
        /// </summary>
        /// <param name="predicate">Function to be ran.</param>
        /// <returns><paramref name="predicate" /> return or default return in case of an error has been thrown.</returns>
        protected IActionResult RunDefault(Func<IActionResult> predicate)
        {
            if (!ModelState.IsValid)
            {
                return InvalidModel();
            }

            try
            {
                return predicate();
            }
            catch (InvalidArgumentException invalidArgumentException)
            {
                return BadRequest(new ParamError
                {
                    Code = invalidArgumentException.Code,
                    Param = invalidArgumentException.ParamName,
                    Message = invalidArgumentException.Message
                });
            }
            catch (Exception exception)
            {
                return StatusCode(500, new Error
                {
                    Code = 0,
                    Message = exception.Message
                });
            }
        }
    }
}