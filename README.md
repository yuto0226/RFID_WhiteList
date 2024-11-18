# Myfare 卡白名單系統

![圖片](https://hackmd.io/_uploads/rJGPT-Ifke.png)

這是一個具有簡易白名單的門禁卡軟體。使用者可以透過掃描 Myfare Classic 1k 卡片，新增或刪除白名單內的 ID。軟體也提供 CLI 介面，可以直接輸入指令與讀卡機溝通，使用更進階的交互方式。

## 使用方式

連接上讀卡機後開啟應用程式。首次開啟會自行嘗試與讀卡機連線，也可以自行選擇通訊埠連線。

App 的介面分為三大區塊：
- Consle：可以透過輸入指令與讀卡機交互，一些事件訊息也會顯示在上面。
- Status：可以看到讀卡機以及卡片的連線狀態。在卡片連線後，會顯示卡號，並且可以選擇加入白名單，或是自白名單中刪除卡片的 ID。
- Setting：設定中可以調整與讀卡機連線的通訊埠，以及白名單的內容。

![圖片](https://hackmd.io/_uploads/r1N8sMUMkl.png)

App 最上面有一條 menu，可以查看、編輯白名單內容。使用者可以根據情況自行添加、編輯或刪除 ID。

![圖片](https://hackmd.io/_uploads/r1GzVf8fJe.png)