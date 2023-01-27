import { applyMiddleware, compose, configureStore } from "@reduxjs/toolkit";
import thunk from "redux-thunk";
import logger from "redux-logger";
import appReducer from "./reducers/app-reducer";

const reducers = {
  app: appReducer,
};

const createStore = (preloadedState?: any) => {
  const store = configureStore({
    reducer: reducers,
    middleware: (getDefaultMiddleware) => getDefaultMiddleware().concat(logger),
    preloadedState: preloadedState,
  });

  return store;
};

export default createStore;
