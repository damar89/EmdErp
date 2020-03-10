using FluentValidation;
using NetSatis.Entities.Interface;
using System.Windows.Forms;

namespace NetSatis.Entities.Tools
{
    public static class ValidatorTool
    {
       public static bool Validate(IValidator validator,IEntity entity)
        {
            bool result = true;
            var validationResult = validator.Validate(entity);
            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var error in validationResult.Errors)
                {
                    message += error.ErrorMessage+System.Environment.NewLine;

                }

                MessageBox.Show(message);
                result = false;
            }


            return result;
        }
    }
}
