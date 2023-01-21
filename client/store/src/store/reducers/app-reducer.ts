import { CaseReducer, createAction, createAsyncThunk, createSlice, PayloadAction } from "@reduxjs/toolkit";
import type { RootState } from "../../index";

interface AppState {
  direction: string;
}

const initialState: AppState = {
  direction: "rtl",
};

export const change: CaseReducer<AppState, PayloadAction<string>> = (state,action) => {
  state.direction = action.payload;
};

export const doChange = createAction<string>('app/doChange')
export const reset = createAction('app/reset')

export const thunkFunc = createAsyncThunk(
  'app/asyncCall',
  async (data: string, tunkApi) => {
    const response = await Promise.resolve<string>(data)
    return response
  }
)



export const appSlice = createSlice({
  name: "app",
  initialState,
  reducers: {
    changeDirection: (state, action: PayloadAction<string>) => {
      state.direction = action.payload;
    },
  },
  extraReducers: builder => {
    builder.addCase(reset, ()=>initialState)
    builder.addCase(doChange, (state, action)=>{
      state.direction = action.payload
    })
    builder.addCase(thunkFunc.fulfilled, (state, action)=>{
      state.direction = action.payload
    })
  }
});


export const { changeDirection } = appSlice.actions;

export default appSlice.reducer;
