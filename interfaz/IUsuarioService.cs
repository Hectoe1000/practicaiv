using models;

public interface IUsuarioService
{
    Task<List<Cliente>> GetUsuariosAsync();
    Task<Cliente> GetUsuarioByIdAsync(int id);
    Task CreateUsuarioAsync(Cliente usuario);
    Task UpdateUsuarioAsync(Cliente usuario);
    Task DeleteUsuarioAsync(int id);
}
