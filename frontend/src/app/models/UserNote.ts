export interface UserNote {
  noteId?: number;
  userId: number;
  title: string;
  content: string;
  isPublic: number;
  isShared?: number;
}
