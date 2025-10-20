using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure.Repositories;

// TODO (Grupo Repository): Implementar métodos usando AppDbContext.
// Focar em persistência apenas. NÃO adicionar regras de negócio.
// Discutir no PR: vantagens e possíveis redundâncias do padrão.
public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> GetAllAsync(CancellationToken ct = default)
    {
        // TODO: retornar lista com AsNoTracking.
        return await _context.Produtos.AsNoTracking().ToListAsync(ct); //Feito.
    }

    public async Task<Produto?> GetByIdAsync(int id, CancellationToken ct = default)
    {
        // TODO: usar FindAsync.
        return await _context.Produtos.FindAsync(id, ct); //Ver se está pronto. 
        // throw new NotImplementedException();
    }

    public async Task AddAsync(Produto produto, CancellationToken ct = default)
    {
        // TODO: AddAsync(produto, ct)
        await _context.Produtos.AddAsync(produto, ct); //Ver se está pronto
        // throw new NotImplementedException();
    }

    public async Task RemoveAsync(Produto produto, CancellationToken ct = default)
    {
        // TODO: _context.Remove(produto)
        _context.Remove(produto); //Ver se está pronto, ver se precisa de await. Se não precisa, pesquisar o porque.
        // throw new NotImplementedException();
    }

    public async Task SaveChangesAsync(CancellationToken ct = default)
    {
        // TODO: _context.SaveChangesAsync(ct)
        await _context.SaveChangesAsync(ct);
        // throw new NotImplementedException();
    }
}
