using System.Threading.Tasks;
using JhipsterExample.Domain.Entities;

namespace JhipsterExample.Domain.Services.Interfaces;

public interface IMailService
{
    Task SendPasswordResetMail(User user);
    Task SendActivationEmail(User user);
    Task SendCreationEmail(User user);
}
