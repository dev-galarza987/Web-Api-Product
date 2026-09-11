namespace WebApiProduct.Dto;

public record ListProductResponse(
    int Id,
    string Name,
    decimal Price,
    int Stock,
    DateTime UpdatedAt
);

public record DetailProductRequest(
    int Id,
    string Name,
    string Description,
    decimal Price,
    int Stock,
    DateTime CreatedAt,
    DateTime UpdatedAt
);