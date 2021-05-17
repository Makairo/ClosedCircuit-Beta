# ClosedCircuit-Beta
Beta MVC for ClosedCurcuit Project

Reqs<br>
| ReqID | Requirement | Test Method | Test ID |
| ----- | ----------- | ----------- | ------- |
| 1.1 | User login / auth | test | 1, 3 |
| 1.2, 1.3 | User views correct menus on login | test | 1, 3 |
| 1.4, 2.1 | Scores are uploaded and stored correctly | inspection, test | 2 |
| 2.2 | Leaderboard is accurate and accessable | inspection | |
| 2.3 | Gameplay is operational | analysis | 4 |
| 2.4 | Database is stored and accessed correctly | inspection |  |

<br>
Testing

| TestID | Req ID | Test Proc | Current | Date |
| ------ | ------ | --------- | ------- | ---- |
| 1      |  1.1,1.2,1.3 | User login, enter, view menus | not tested |  |
| 2      | 1.4, 2.1 | Complete game, enter auth, upload score | not tested | |
| 3      | 2.1, 1.2 | User login, select view Leaderboard, validate scores are listed and can be filtered | not tested | |
| 4      | 2.3 | Mock game scenario, place towers and spawn enemies, game should run independently of user regardless of setup | partially working | 5/13/21 |
