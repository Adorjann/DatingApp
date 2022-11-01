export interface Message {
    id:                number;
    senderId:          number;
    senderUserName:    string;
    senderPhotoUrl:    string;
    recipientId:       number;
    recipientUsername: string;
    recipientPhotoUrl: string;
    conttent:          string;
    dateRead:          Date;
    messageSent:       Date;
}