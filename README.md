# tdd-workshop

2023/08/01(火)「TDDワークショップ　by twadaさん」

## 演習問題

- 整数の閉区間(短めの問題分)
  - [あらかじめ問題を分解した](https://gist.github.com/twada/29247a921e5e977c028f478b30af3248)
  - [自力でTODO 分解版](https://gist.github.com/twada/df6bf4b2d1828919f778cac705cd2ea8)
- 整数の閉区間(長めの問題分)
  - [あらかじめ問題を分解した](https://gist.github.com/twada/3a6b068942810b89679f)
  - [自力でTODO 分解版](https://gist.github.com/twada/75fb219c8cc180e9de166d8a58e877b0)

### デモのTODOリスト

```
TODO
======================

テスト容易性: 高
- [x] 数を文字列に変換する
  - [x] 1を渡すと文字列"1"を返す -> 仮実装
  - [x] 2を渡すと文字列"2"を返す -> 三角測量

- [x] 3の倍数のときは数の代わりに｢Fizz｣に変換する
  - [x] 3を渡すと文字列"Fizz"を返す -> 仮実装 -> 本実装

- [x] 5の倍数のときは数の代わりに｢Buzz｣に変換する
  - [x] 5を渡すと文字列"Buzz"を返す -> 明白な実装

- [ ] 3と5両方の倍数のときは数の代わりに｢FizzBuzz｣に変換する

- [ ] 1からnまでの数

テスト容易性: 中
- [ ] 1から100までの数

テスト容易性: 低
- [ ] プリントする
```

```
テスト容易性（テストの書きやすさ、行いやすさ）

- 観測容易性（テスト対象の実行結果の自動テストからの調べやすさ）
- 制御容易性（テスト対象の動かしやすさ）
- 小ささ（テスト対象のコードやシグネチャの大きさ）


テスト容易性を下げるもの
- 外部入出力
	- ネットワーク
	- DB
	- ファイル
- ランダム性
- 現在時刻
- 巨大なコード、関数
```

## おかわり問題

- [整数の開区間](https://gist.github.com/twada/b875014506653da64a3b136191c48e6f)

## 和田さんからのお土産

- [テストコードのリファクタリングが目指すもの](https://dxd2021.cto-a.org/program/time-table/a-1)
- [TDDワークショップお題「整数の閉区間」を Go でライブコーディング](https://gist.github.com/twada/51c89eb424437b36e4d0b25ae9060b84)
- [サバンナ便り〜自動テストに関する連載で得られた知見のまとめ（2023年5月版）](https://speakerdeck.com/twada/automated-test-knowledge-from-savanna-202305-edition?slide=2)
- [Qiita Conference 2023 Day1](https://www.youtube.com/watch?v=nERe7yNgeVU&t=6975s)
