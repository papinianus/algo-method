文字列は文字が連なってできており、いくつかの要素が連なったリストと密接な関係があります。

たとえば、文字列から特定位置の文字を抜き出すには、リストの場合と同様に `[]` 記法を用います。

次のコードは、`algorithm` という文字列の前から 3 文字目を抜き出すものです。

リストと同様、はじめの文字を 0 番目と数えていることに注意してください。

```python
S = "algorithm"
print(S[3]) # 出力: "o"
```

## 問題文

文字列 S の先頭と最後の文字をつなげて略称を作り出力するプログラムを作成してください。

たとえば、 S が `algomethod` である場合は略称である `ad` を出力します。

問題を解く際に変数 S の値を変更して実験しても構いません。

ただし、解答を提出する際は S の値を `programming` に戻してください。

### ヒント: 最後の文字

文字列型の変数 S の最後の文字は `S[-1]` と書くことで取得できます。