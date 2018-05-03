# FtdLuaBuilder
From The Depths用のLUAファイルまとめツール

## 機能
seedファイルを精査し、`--{@filename}`の箇所をlibファイルの内容に置換し、outputファイルに出力します。

また、リストボックスで選択しているファイルをビルドした場合、出力結果をクリップボードにコピーします。

### 例

seed folder内ファイル test.lua

```lua:test.lua
local A = 0
local B = 0
-- {@lib.lua}
```

lib folder内ファイル lib.lua

```lua:lib.lua
local LIB = 0
```

output folder内ファイル test.lua

```lua:test.lua
local A = 0
local B = 0
-- lib.lua offset 3 rows
local LIB = 0
```
## 入力項目
#### seed folder
元になるファイルのフォルダ

#### lib folder
参照先フォルダ

#### output folder
出力先フォルダ

#### build all
チェックをつけてbuildすると、seedフォルダ内の全ファイルをビルドする。

#### build
手動ビルド

#### start at startup
起動時に自動的にstartするか否か

#### start
seedフォルダとlibフォルダを監視し、変化があれば自動ビルドする。

#### stop
監視を停止する。

#### clipboard notify
currentをビルドした際に出力結果をクリップボードにコピーしたことをOSに通知するか否か。

#### select current
seedフォルダ内のファイル一覧。
選択しておくとビルド時に出力結果をクリップボードにコピーする


