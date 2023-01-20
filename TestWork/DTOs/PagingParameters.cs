namespace TestWork.DTOs;

public class PagingParameters
{
    private int _pageSize = 10;
        
    public int PageNumber { get; set; } = 1;

    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = Math.Min(value, 50);
    }
}