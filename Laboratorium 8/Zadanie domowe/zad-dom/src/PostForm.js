import React, { useEffect } from 'react';
import { Form, InputNumber, Input, Button } from 'antd';

const PostForm = ({ onFinish, submitText, initialValues }) => {
	const [form] = Form.useForm();

	useEffect(() => {
		form.setFieldsValue(initialValues);
	}, [form, initialValues]);

	return (
		<Form form={form} layout='vertical' onFinish={onFinish} initialValues={initialValues}>
			<Form.Item name='userId' label='Id użytkownika'>
				<InputNumber />
			</Form.Item>
			<Form.Item name='id' label='Id posta'>
				<InputNumber />
			</Form.Item>
			<Form.Item name='title' label='Tytuł'>
				<Input placeholder='Tytuł posta' />
			</Form.Item>
			<Form.Item name='body' label='Opis'>
				<Input placeholder='Opis' />
			</Form.Item>
			<Form.Item className='text-center'>
				<Button className='w-100' htmlType='submit' size='large' type='primary'>
					{submitText}
				</Button>
			</Form.Item>
		</Form>
	);
};

export default PostForm;