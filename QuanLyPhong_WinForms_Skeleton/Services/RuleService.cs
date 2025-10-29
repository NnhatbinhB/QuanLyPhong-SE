namespace QuanLyPhong_WinForms_Skeleton.Services;

public static class RuleService
{
    public static decimal TinhPhiXeMay(int soXe)
    {
        if (soXe <= 1) return 0;
        return (soXe - 1) * 100_000m;
    }
}
