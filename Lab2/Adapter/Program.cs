
using Adapter;

MetricMap map = new MetricMap();
IAmericanTouristClient americanTouristWithKmMilesConverter = new AmericanTouristMetricMapAdapter(map);

americanTouristWithKmMilesConverter.MoveInMiles();