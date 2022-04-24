export interface User {
  userId?: number;
  email: string;
  password?: string;
  currentPassword?: string;
  newPassword?: string;
  firstName?: string;
  lastName?: string;
  username?: string;
  error?: string;
}
