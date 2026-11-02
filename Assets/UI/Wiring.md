# BMU tour wiring (generated)

`Show(X)` = X.SetActive(true) + X.Animator.SetTrigger("Show") + X voiceover Play. `Exit(X)` = X.Animator.SetTrigger("Exit") + X voiceover Stop.
A screen that has exited stays active but invisible and click-through; `Show` re-opens it (see D3).

| Screen | Button | Actions |
|---|---|---|
| Intro_1 | Btn_Next | Exit(Intro_1) + Show(Intro_2) |
| Intro_1 | Btn_NextArrow | Exit(Intro_1) + Show(Intro_2) |
| Intro_1 | Btn_Prev | _(none)_ |
| Intro_1 | Btn_Skip | Exit(Intro_1) + Show(Hub) |
| Intro_2 | Btn_Next | Exit(Intro_2) + Show(Intro_3) |
| Intro_2 | Btn_NextArrow | Exit(Intro_2) + Show(Intro_3) |
| Intro_2 | Btn_Prev | Exit(Intro_2) + Show(Intro_1) |
| Intro_2 | Btn_Skip | Exit(Intro_2) + Show(Hub) |
| Intro_2 | Btn_StartTourAgain | Exit(Intro_2) + Show(Intro_1) + Teleport.GoTo(Start) |
| Intro_3 | Btn_Next | Exit(Intro_3) + Show(Intro_4) |
| Intro_3 | Btn_NextArrow | Exit(Intro_3) + Show(Intro_4) |
| Intro_3 | Btn_Prev | Exit(Intro_3) + Show(Intro_2) |
| Intro_3 | Btn_Skip | Exit(Intro_3) + Show(Hub) |
| Intro_3 | Btn_StartTourAgain | Exit(Intro_3) + Show(Intro_1) + Teleport.GoTo(Start) |
| Intro_4 | Btn_Next | Exit(Intro_4) + Show(Intro_5) |
| Intro_4 | Btn_NextArrow | Exit(Intro_4) + Show(Intro_5) |
| Intro_4 | Btn_Prev | Exit(Intro_4) + Show(Intro_3) |
| Intro_4 | Btn_Skip | Exit(Intro_4) + Show(Hub) |
| Intro_4 | Btn_StartTourAgain | Exit(Intro_4) + Show(Intro_1) + Teleport.GoTo(Start) |
| Intro_5 | Btn_Next | Exit(Intro_5) + Show(Hub) |
| Intro_5 | Btn_NextArrow | _(none)_ |
| Intro_5 | Btn_Prev | Exit(Intro_5) + Show(Intro_4) |
| Intro_5 | Btn_Skip | Exit(Intro_5) + Show(Hub) |
| Intro_5 | Btn_StartTourAgain | Exit(Intro_5) + Show(Intro_1) + Teleport.GoTo(Start) |
| Hub | Btn_Teleport | Exit(Hub) + Teleport.GoTo(OutsideNB) + Show(Outside_NB) |
| Hub | Btn_Teleport | Exit(Hub) + Teleport.GoTo(OutsideGA) + Show(Outside_GA) |
| Hub | Btn_Teleport | Exit(Hub) + Teleport.GoTo(OutsideWorkshop) + Show(Outside_Workshop) |
| Hub | Btn_StartTourAgain | Exit(Hub) + Show(Intro_1) + Teleport.GoTo(Start) |
| Outside_NB | Btn_1 | Outside_NB.SetTrigger(Dim) + Show(Selector_NB_FromOutside) |
| Outside_NB | Btn_2 | Exit(Outside_NB) + Show(Hub) |
| Outside_NB | Btn_3 | Exit(Outside_NB) + Show(Hub) |
| Outside_NB | Btn_Minimize | Outside_NB.SetTrigger(Minimize) |
| Outside_NB | Btn_Restore | Outside_NB.SetTrigger(Restore) |
| Outside_NB | Btn_StartTourAgain | Exit(Outside_NB) + Show(Intro_1) + Teleport.GoTo(Start) |
| Selector_NB_FromOutside | Btn_Cancel | Exit(Selector_NB_FromOutside) + Outside_NB.SetTrigger(Undim) |
| Selector_NB_FromOutside | Row_1 | Exit(Selector_NB_FromOutside) + Exit(Outside_NB) + Teleport.GoTo(Room_NB_Classroom) + Show(Room_NB_Classroom) |
| Selector_NB_FromOutside | Row_2 | Exit(Selector_NB_FromOutside) + Exit(Outside_NB) + Teleport.GoTo(Room_NB_EngLab) + Show(Room_NB_EngLab) |
| Selector_NB_FromOutside | Row_3 | Exit(Selector_NB_FromOutside) + Exit(Outside_NB) + Teleport.GoTo(Room_NB_Faculty) + Show(Room_NB_Faculty) |
| Selector_NB_FromOutside | Btn_StartTourAgain | Exit(Selector_NB_FromOutside) + Exit(Outside_NB) + Show(Intro_1) + Teleport.GoTo(Start) |
| Room_NB_Classroom | Btn_1 | Room_NB_Classroom.SetTrigger(Dim) + Show(Selector_NB_FromRoom_Classroom) |
| Room_NB_Classroom | Btn_2 | Exit(Room_NB_Classroom) + Teleport.GoTo(OutsideNB) + Show(Outside_NB) |
| Room_NB_Classroom | Btn_Minimize | Room_NB_Classroom.SetTrigger(Minimize) |
| Room_NB_Classroom | Btn_Restore | Room_NB_Classroom.SetTrigger(Restore) |
| Room_NB_Classroom | Btn_StartTourAgain | Exit(Room_NB_Classroom) + Show(Intro_1) + Teleport.GoTo(Start) |
| Selector_NB_FromRoom_Classroom | Btn_Cancel | Exit(Selector_NB_FromRoom_Classroom) + Room_NB_Classroom.SetTrigger(Undim) |
| Selector_NB_FromRoom_Classroom | Row_1 | Exit(Selector_NB_FromRoom_Classroom) + Exit(Room_NB_Classroom) + Teleport.GoTo(Room_NB_Classroom) + Show(Room_NB_Classroom) |
| Selector_NB_FromRoom_Classroom | Row_2 | Exit(Selector_NB_FromRoom_Classroom) + Exit(Room_NB_Classroom) + Teleport.GoTo(Room_NB_EngLab) + Show(Room_NB_EngLab) |
| Selector_NB_FromRoom_Classroom | Row_3 | Exit(Selector_NB_FromRoom_Classroom) + Exit(Room_NB_Classroom) + Teleport.GoTo(Room_NB_Faculty) + Show(Room_NB_Faculty) |
| Selector_NB_FromRoom_Classroom | Btn_StartTourAgain | Exit(Selector_NB_FromRoom_Classroom) + Exit(Room_NB_Classroom) + Show(Intro_1) + Teleport.GoTo(Start) |
| Room_NB_EngLab | Btn_1 | Room_NB_EngLab.SetTrigger(Dim) + Show(Selector_NB_FromRoom_EngLab) |
| Room_NB_EngLab | Btn_2 | Exit(Room_NB_EngLab) + Teleport.GoTo(OutsideNB) + Show(Outside_NB) |
| Room_NB_EngLab | Btn_Minimize | Room_NB_EngLab.SetTrigger(Minimize) |
| Room_NB_EngLab | Btn_Restore | Room_NB_EngLab.SetTrigger(Restore) |
| Room_NB_EngLab | Btn_StartTourAgain | Exit(Room_NB_EngLab) + Show(Intro_1) + Teleport.GoTo(Start) |
| Selector_NB_FromRoom_EngLab | Btn_Cancel | Exit(Selector_NB_FromRoom_EngLab) + Room_NB_EngLab.SetTrigger(Undim) |
| Selector_NB_FromRoom_EngLab | Row_1 | Exit(Selector_NB_FromRoom_EngLab) + Exit(Room_NB_EngLab) + Teleport.GoTo(Room_NB_Classroom) + Show(Room_NB_Classroom) |
| Selector_NB_FromRoom_EngLab | Row_2 | Exit(Selector_NB_FromRoom_EngLab) + Exit(Room_NB_EngLab) + Teleport.GoTo(Room_NB_EngLab) + Show(Room_NB_EngLab) |
| Selector_NB_FromRoom_EngLab | Row_3 | Exit(Selector_NB_FromRoom_EngLab) + Exit(Room_NB_EngLab) + Teleport.GoTo(Room_NB_Faculty) + Show(Room_NB_Faculty) |
| Selector_NB_FromRoom_EngLab | Btn_StartTourAgain | Exit(Selector_NB_FromRoom_EngLab) + Exit(Room_NB_EngLab) + Show(Intro_1) + Teleport.GoTo(Start) |
| Room_NB_Faculty | Btn_1 | Room_NB_Faculty.SetTrigger(Dim) + Show(Selector_NB_FromRoom_Faculty) |
| Room_NB_Faculty | Btn_2 | Exit(Room_NB_Faculty) + Teleport.GoTo(OutsideNB) + Show(Outside_NB) |
| Room_NB_Faculty | Btn_Minimize | Room_NB_Faculty.SetTrigger(Minimize) |
| Room_NB_Faculty | Btn_Restore | Room_NB_Faculty.SetTrigger(Restore) |
| Room_NB_Faculty | Btn_StartTourAgain | Exit(Room_NB_Faculty) + Show(Intro_1) + Teleport.GoTo(Start) |
| Selector_NB_FromRoom_Faculty | Btn_Cancel | Exit(Selector_NB_FromRoom_Faculty) + Room_NB_Faculty.SetTrigger(Undim) |
| Selector_NB_FromRoom_Faculty | Row_1 | Exit(Selector_NB_FromRoom_Faculty) + Exit(Room_NB_Faculty) + Teleport.GoTo(Room_NB_Classroom) + Show(Room_NB_Classroom) |
| Selector_NB_FromRoom_Faculty | Row_2 | Exit(Selector_NB_FromRoom_Faculty) + Exit(Room_NB_Faculty) + Teleport.GoTo(Room_NB_EngLab) + Show(Room_NB_EngLab) |
| Selector_NB_FromRoom_Faculty | Row_3 | Exit(Selector_NB_FromRoom_Faculty) + Exit(Room_NB_Faculty) + Teleport.GoTo(Room_NB_Faculty) + Show(Room_NB_Faculty) |
| Selector_NB_FromRoom_Faculty | Btn_StartTourAgain | Exit(Selector_NB_FromRoom_Faculty) + Exit(Room_NB_Faculty) + Show(Intro_1) + Teleport.GoTo(Start) |
| Outside_GA | Btn_1 | Outside_GA.SetTrigger(Dim) + Show(Selector_GA_FromOutside) |
| Outside_GA | Btn_2 | Exit(Outside_GA) + Show(Hub) |
| Outside_GA | Btn_3 | Exit(Outside_GA) + Show(Hub) |
| Outside_GA | Btn_Minimize | Outside_GA.SetTrigger(Minimize) |
| Outside_GA | Btn_Restore | Outside_GA.SetTrigger(Restore) |
| Outside_GA | Btn_StartTourAgain | Exit(Outside_GA) + Show(Intro_1) + Teleport.GoTo(Start) |
| Selector_GA_FromOutside | Btn_Cancel | Exit(Selector_GA_FromOutside) + Outside_GA.SetTrigger(Undim) |
| Selector_GA_FromOutside | Row_1 | Exit(Selector_GA_FromOutside) + Exit(Outside_GA) + Teleport.GoTo(Room_GA_Reception) + Show(Room_GA_Reception) |
| Selector_GA_FromOutside | Row_2 | Exit(Selector_GA_FromOutside) + Exit(Outside_GA) + Teleport.GoTo(Room_GA_ProgramOffice) + Show(Room_GA_ProgramOffice) |
| Selector_GA_FromOutside | Btn_StartTourAgain | Exit(Selector_GA_FromOutside) + Exit(Outside_GA) + Show(Intro_1) + Teleport.GoTo(Start) |
| Room_GA_Reception | Btn_1 | Room_GA_Reception.SetTrigger(Dim) + Show(Selector_GA_FromRoom_Reception) |
| Room_GA_Reception | Btn_2 | Exit(Room_GA_Reception) + Teleport.GoTo(OutsideGA) + Show(Outside_GA) |
| Room_GA_Reception | Btn_Minimize | Room_GA_Reception.SetTrigger(Minimize) |
| Room_GA_Reception | Btn_Restore | Room_GA_Reception.SetTrigger(Restore) |
| Room_GA_Reception | Btn_StartTourAgain | Exit(Room_GA_Reception) + Show(Intro_1) + Teleport.GoTo(Start) |
| Selector_GA_FromRoom_Reception | Btn_Cancel | Exit(Selector_GA_FromRoom_Reception) + Room_GA_Reception.SetTrigger(Undim) |
| Selector_GA_FromRoom_Reception | Row_1 | Exit(Selector_GA_FromRoom_Reception) + Exit(Room_GA_Reception) + Teleport.GoTo(Room_GA_Reception) + Show(Room_GA_Reception) |
| Selector_GA_FromRoom_Reception | Row_2 | Exit(Selector_GA_FromRoom_Reception) + Exit(Room_GA_Reception) + Teleport.GoTo(Room_GA_ProgramOffice) + Show(Room_GA_ProgramOffice) |
| Selector_GA_FromRoom_Reception | Btn_StartTourAgain | Exit(Selector_GA_FromRoom_Reception) + Exit(Room_GA_Reception) + Show(Intro_1) + Teleport.GoTo(Start) |
| Room_GA_ProgramOffice | Btn_1 | Room_GA_ProgramOffice.SetTrigger(Dim) + Show(Selector_GA_FromRoom_ProgramOffice) |
| Room_GA_ProgramOffice | Btn_2 | Exit(Room_GA_ProgramOffice) + Teleport.GoTo(OutsideGA) + Show(Outside_GA) |
| Room_GA_ProgramOffice | Btn_Minimize | Room_GA_ProgramOffice.SetTrigger(Minimize) |
| Room_GA_ProgramOffice | Btn_Restore | Room_GA_ProgramOffice.SetTrigger(Restore) |
| Room_GA_ProgramOffice | Btn_StartTourAgain | Exit(Room_GA_ProgramOffice) + Show(Intro_1) + Teleport.GoTo(Start) |
| Selector_GA_FromRoom_ProgramOffice | Btn_Cancel | Exit(Selector_GA_FromRoom_ProgramOffice) + Room_GA_ProgramOffice.SetTrigger(Undim) |
| Selector_GA_FromRoom_ProgramOffice | Row_1 | Exit(Selector_GA_FromRoom_ProgramOffice) + Exit(Room_GA_ProgramOffice) + Teleport.GoTo(Room_GA_Reception) + Show(Room_GA_Reception) |
| Selector_GA_FromRoom_ProgramOffice | Row_2 | Exit(Selector_GA_FromRoom_ProgramOffice) + Exit(Room_GA_ProgramOffice) + Teleport.GoTo(Room_GA_ProgramOffice) + Show(Room_GA_ProgramOffice) |
| Selector_GA_FromRoom_ProgramOffice | Btn_StartTourAgain | Exit(Selector_GA_FromRoom_ProgramOffice) + Exit(Room_GA_ProgramOffice) + Show(Intro_1) + Teleport.GoTo(Start) |
| Outside_Workshop | Btn_2 | Exit(Outside_Workshop) + Show(Hub) |
| Outside_Workshop | Btn_3 | Exit(Outside_Workshop) + Show(Hub) |
| Outside_Workshop | Btn_Minimize | Outside_Workshop.SetTrigger(Minimize) |
| Outside_Workshop | Btn_Restore | Outside_Workshop.SetTrigger(Restore) |
| Outside_Workshop | Btn_StartTourAgain | Exit(Outside_Workshop) + Show(Intro_1) + Teleport.GoTo(Start) |

Spawn transforms (placeholders, under `TourSpawns`): Start, OutsideNB, OutsideGA, OutsideWorkshop, Room_NB_Classroom, Room_NB_EngLab, Room_NB_Faculty, Room_GA_Reception, Room_GA_ProgramOffice.
Persistent OnClick listeners: 511.
