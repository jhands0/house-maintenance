const baseUrl = process.env.FRONTEND_API_URL;
const taskControllerUrl = `${baseUrl}/TaskController`;
export const getAllUrl = `${taskControllerUrl}/GetAll`;