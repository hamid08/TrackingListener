namespace TrackingListener.Application.Common.Extensions;

public static class ArrayExtensions
{
    public static T[] SubArray<T>(this T[] array, int startIndex, int endIndex)
    {
        T[] subArray = array[startIndex..endIndex];

        return subArray;
    }
}