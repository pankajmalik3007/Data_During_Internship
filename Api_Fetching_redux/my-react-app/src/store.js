
import { configureStore, getDefaultMiddleware } from '@reduxjs/toolkit';
import thunk from 'redux-thunk'; 
import counterReducer from './Reducer/counterReducer';

const middleware = [...getDefaultMiddleware(), thunk]; 

const store = configureStore({
  reducer: {
    counter: counterReducer,
  },
  middleware: middleware,
});

export default store;
