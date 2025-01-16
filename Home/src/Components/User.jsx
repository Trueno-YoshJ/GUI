export const users = [];

export const addUser = (newUser) => {
  users.push(newUser);
};

export const findUser = (email, password) => {
  return users.find((user) => user.email === email && user.password === password);
};

export const findUserByEmail = (email) => {
  return users.find((user) => user.email === email);
};
