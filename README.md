# 心得反思
這次的專案是利用C#與Windows Forms製作一個**模擬按鍵式手機**的應用程式，功能包括撥號、簡訊、計算機以及顯示當前時間等模組。整個製作過程讓我對 Windows Forms 控制項、事件觸發、以及多功能程式整合有了更深入的理解。

在撥號功能的設計上，我使用了 Button 與 TextBox 控制撥號號碼的輸入，並結合 Timer 顯示即時時間。此外，還加入了刪除按鍵、返回主頁面以及撥號按鈕事件，並在撥號時將號碼傳遞到另一個撥號確認視窗。這個過程讓我更擅如何使用事件處理與Form間的**資料傳遞**，並加強了對程式流程的掌握。

簡訊功能則是對多按鍵輸入法的模擬，這是整個專案最具挑戰性的部分。我設計了一個字典來對應每個按鍵對應的字母，並判斷使用者是否連續按同一個按鍵，實現文字切換的功能。這段程式碼讓我更理解了**時間計算、狀態判斷與控制流程**的重要性，也培養我分析問題的**邏輯思維**。

計算機功能則模擬了實際按鍵式手機的四則運算操作，除了數字輸入外，我還實作了加減乘除的狀態判斷，以及連續運算的邏輯處理。這部分讓我熟悉了**變數狀態管理、流程控制與條件判斷的運用**。

在整個專案過程中，我遇到的最大挑戰是如何**整合多個功能模組**，並保持操作邏輯的連貫性。例如，簡訊多按鍵輸入的計數與連續判斷、計算機多符號操作的狀態切換，這些都需要細心檢查事件觸發的順序以及變數狀態的正確性。透過不斷測試與修正，我學會了更有效率地調試程式，並養成寫出易讀且結構清楚的程式碼的習慣。

這次專案不僅讓我熟悉了Windows Forms的各種控制項使用，還加強了我對**事件驅動程式設計**的理解。同時，透過多功能整合的過程，我提升了程式邏輯規劃與問題解決的能力，也更加體會到**使用者介面設計與操作便利性**的重要性。未來如果要開發更完整的應用程式，我能更清楚地規劃功能架構、模組分工與使用者互動流程。

總結來說，這個專案是一次非常實用的程式設計練習，它結合了文字處理、計算邏輯與表單操作，也鍛鍊了我對事件驅動與多功能程式整合的能力。

執行畫面

<img width="480" height="867" alt="image" src="https://github.com/user-attachments/assets/7edd75f1-5307-4dae-a9c7-36b4d087ddb8" />

<img width="469" height="858" alt="image" src="https://github.com/user-attachments/assets/bf0fa567-da1d-4054-911b-7400021efb70" />

<img width="464" height="771" alt="image" src="https://github.com/user-attachments/assets/d68fa220-2d9b-4b09-abd2-4360930662f7" />

<img width="461" height="861" alt="image" src="https://github.com/user-attachments/assets/93c77002-5403-43ed-b5d6-b350656c7063" />



<img width="467" height="772" alt="image" src="https://github.com/user-attachments/assets/46c712a1-e858-438d-8354-b1ee8cd5babf" /><img width="466" height="780" alt="image" src="https://github.com/user-attachments/assets/c4334339-b8ac-4ae2-94ec-bc5c08541c98" />



