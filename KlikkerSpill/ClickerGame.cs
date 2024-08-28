namespace KlikkerSpill;

public class ClickerGame
{
    private int _points = 0;
    private int _pointsPerClick = 1;
    private int _pointsPerClickIncrease = 1;

    public void PointsIncrease()
    {
        _points += _pointsPerClick;
    }

    public void PointsUpgrade()
    {
        if(_points < 10) return;
        _points -= 10;
        _pointsPerClick++;
    }

    public void UpgradeIncrease()
    {
        if(_points < 100) return;
        _points -= 100;
        _pointsPerClickIncrease++;
    }

    public int GetPoints()
    {
        return _points;
    }
}