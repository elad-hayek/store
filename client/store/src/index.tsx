import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import App from "./App";
import createStore from "./store/configureStore";
import { Provider } from "react-redux";

const store = createStore();

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

const root = ReactDOM.createRoot(
  document.getElementById("root") as HTMLElement
);
root.render(
  <Provider store={store}>
    <App />
  </Provider>
);
