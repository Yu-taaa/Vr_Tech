public interface IButton
{
    void OnPressed();
}
//こちらは親を子クラスが継承する、というところは同じですが、いくつか特徴があります。
//複数の継承が可能(継承の場合は1つのみ)
//Interface自身はクラスを継承することはできない
//Interface自身は実装を持たない