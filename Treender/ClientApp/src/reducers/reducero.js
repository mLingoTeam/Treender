const initState = {
  username: "Mieczkowski69"
};

const reducero = (state = initState, action) => {
  if (action.type == "CHANGE_NAME") {
    let username = action.username;
    return {
      ...state,
      ...state[0],
      username
    };
  }

  return state;
};

export default reducero;
