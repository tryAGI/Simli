#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ListedAsset : global::System.IEquatable<ListedAsset>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Simli.Asset? Asset { get; init; }
#else
        public global::Simli.Asset? Asset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Asset))]
#endif
        public bool IsAsset => Asset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Simli.Asset? value)
        {
            value = Asset;
            return IsAsset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Simli.Asset PickAsset() => Asset is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Asset' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Simli.ListedAssetVariant2? ListedAssetVariant2 { get; init; }
#else
        public global::Simli.ListedAssetVariant2? ListedAssetVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListedAssetVariant2))]
#endif
        public bool IsListedAssetVariant2 => ListedAssetVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListedAssetVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Simli.ListedAssetVariant2? value)
        {
            value = ListedAssetVariant2;
            return IsListedAssetVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Simli.ListedAssetVariant2 PickListedAssetVariant2() => ListedAssetVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListedAssetVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListedAsset(global::Simli.Asset value) => new ListedAsset((global::Simli.Asset?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Simli.Asset?(ListedAsset @this) => @this.Asset;

        /// <summary>
        ///
        /// </summary>
        public ListedAsset(global::Simli.Asset? value)
        {
            Asset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListedAsset FromAsset(global::Simli.Asset? value) => new ListedAsset(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListedAsset(global::Simli.ListedAssetVariant2 value) => new ListedAsset((global::Simli.ListedAssetVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Simli.ListedAssetVariant2?(ListedAsset @this) => @this.ListedAssetVariant2;

        /// <summary>
        ///
        /// </summary>
        public ListedAsset(global::Simli.ListedAssetVariant2? value)
        {
            ListedAssetVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListedAsset FromListedAssetVariant2(global::Simli.ListedAssetVariant2? value) => new ListedAsset(value);

        /// <summary>
        ///
        /// </summary>
        public ListedAsset(
            global::Simli.Asset? asset,
            global::Simli.ListedAssetVariant2? listedAssetVariant2
            )
        {
            Asset = asset;
            ListedAssetVariant2 = listedAssetVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ListedAssetVariant2 as object ??
            Asset as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Asset?.ToString() ??
            ListedAssetVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAsset && IsListedAssetVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Simli.Asset, TResult>? asset = null,
            global::System.Func<global::Simli.ListedAssetVariant2, TResult>? listedAssetVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Asset is { } __value0 && asset != null)
            {
                return asset(__value0);
            }
            else if (ListedAssetVariant2 is { } __value1 && listedAssetVariant2 != null)
            {
                return listedAssetVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Simli.Asset>? asset = null,

            global::System.Action<global::Simli.ListedAssetVariant2>? listedAssetVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Asset is { } __value0)
            {
                asset?.Invoke(__value0);
            }
            else if (ListedAssetVariant2 is { } __value1)
            {
                listedAssetVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Simli.Asset>? asset = null,
            global::System.Action<global::Simli.ListedAssetVariant2>? listedAssetVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Asset is { } __value0)
            {
                asset?.Invoke(__value0);
            }
            else if (ListedAssetVariant2 is { } __value1)
            {
                listedAssetVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Asset,
                typeof(global::Simli.Asset),
                ListedAssetVariant2,
                typeof(global::Simli.ListedAssetVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ListedAsset other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Simli.Asset?>.Default.Equals(Asset, other.Asset) &&
                global::System.Collections.Generic.EqualityComparer<global::Simli.ListedAssetVariant2?>.Default.Equals(ListedAssetVariant2, other.ListedAssetVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ListedAsset obj1, ListedAsset obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListedAsset>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListedAsset obj1, ListedAsset obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListedAsset o && Equals(o);
        }
    }
}
