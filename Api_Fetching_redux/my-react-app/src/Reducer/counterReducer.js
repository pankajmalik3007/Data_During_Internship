
import { ADD_DATA, DELETE_DATA } from "../Action/counterAction";

const initialState = {
  data: []
};

const counterReducer = (state = initialState, action) => {
  switch (action.type) {
    case ADD_DATA:
      return {
        ...state,
        data: [...state.data, ...(Array.isArray(action.payload) ? action.payload : [action.payload])]
      };
    case DELETE_DATA:
      return {
        ...state,
        data: []
      };
    default:
      return state;
  }
};

export default counterReducer;
