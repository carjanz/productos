export interface FuseConfirmationConfig
{
    title?: string;
    message?: string;
    icon?: {
        show?: boolean;
        name?: string;
        color?: 'primary' | 'accent' | 'warn' | 'basic' | 'info' | 'success' | 'warning' | 'error';
    };
    actions?: {
        confirm?: {
            show?: boolean;
            label?: string;
            color?: 'primary' | 'accent' | 'warn' | 'warning' | 'info';
            icon?: {
                show?: boolean;
                name?: string;
            }
        };
        cancel?: {
            show?: boolean;
            label?: string;
            icon?: {
                show?: boolean;
                name?: string;
            }
        };
    };
    dismissible?: boolean;
    style?: string;
}
