# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

```bash
dotnet watch run       # 開發用，存檔自動重啟
dotnet build           # 只建置，驗證是否有編譯錯誤
dotnet run             # 建置並執行（不自動重啟）
```

**每次修改 `.cs` 檔後必須執行 `dotnet build` 確認無錯誤再回報。**

## Architecture

標準三層 ASP.NET Core Web API 結構：

- `Controllers/` — HTTP 入口，負責接收請求與回傳回應，不含商業邏輯
- `Services/` — 商業邏輯，透過 DI 注入至 Controller
- `Models/` — 資料模型，優先使用 `record` 定義不可變的 DTO
- `Program.cs` — 服務註冊（`builder.Services`）與 middleware 設定（`app.Use*`）

DI 生命週期預設使用 `AddScoped`（每個 HTTP request 一個實例）。

## Configuration

- `Properties/launchSettings.json` — 開發用 port 設定（http: 5287）
- `appsettings.Development.json` — 開發環境 log 等級設定
- HttpLogging 僅記錄 `RequestMethod`、`RequestPath`、`RequestQuery`、`ResponseStatusCode`、`Duration`
