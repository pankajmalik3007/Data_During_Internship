import { INCREMENT,DECREMENT,RESET } from "../Action/counterActions";

const initialState = {
  count: 0
};

const counterReducer = (state = initialState, action) => {
  switch (action.type) {
    case INCREMENT:
      return { ...state, count: state.count + 100 };
    case DECREMENT:
      return { ...state, count: state.count - 100 };
    case RESET:
      return { ...state, count: 0 };
    default:
      return state;
  }
};

export default counterReducer;
