import React from "react";
import "./App.scss";
import { useAppDispatch } from "./hooks/useAppDispatch";
import { useAppSelector } from "./hooks/useAppSelector";
import { changeDirection, change, doChange, reset } from "./store/reducers/app-reducer";

function App() {
  const appState = useAppSelector((state) => state.app);
  const dispatch = useAppDispatch();

  return (
    <div className="App">
      <div>{appState.direction}</div>
      <button onClick={()=>{dispatch(doChange("do change"))}}>do change</button>
      <button onClick={()=>{dispatch(reset())}}>reset</button>
      <button onClick={()=>{dispatch(changeDirection("change direction"))}}>changeDirection</button>
      {/* <button onClick={()=>{dispatch(change("change direction"))}}>change</button> */}
    </div>
  );
}

export default App;
