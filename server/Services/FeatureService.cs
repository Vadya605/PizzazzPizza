public class FeatureService
{
    private EF_DataContext _dataContext;
    public FeatureService(EF_DataContext dataContext){
        _dataContext = dataContext;
    }

    public List<Feature>? GetProductFeatures(int productId){
        List<Feature> productFeatures = _dataContext.ProductFeatures.Where(
            pf => pf.productId == productId
        ).Join(_dataContext.Features, 
            pf => pf.featureId,
            f => f.id,
            (pf, f) => new Feature{
                featureTitle = f.featureTitle,
                featureValue = f.featureValue
            }
        ).ToList();
        return productFeatures.Any()? productFeatures: null;
    }
}