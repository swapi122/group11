




/*
'===============================================================================
'  LinqHelper.DAO.PhanLoaiDoiTuongBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqPhanLoaiDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqPhanLoaiDoiTuongEntity obj)
		{
			provider.GetTable<LqPhanLoaiDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqPhanLoaiDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqPhanLoaiDoiTuongEntity tmp = q.First<LqPhanLoaiDoiTuongEntity>();
			
			tmp.IdDoiTuong = _obj.IdDoiTuong;
			tmp.TrangThaiPhanLoai = _obj.TrangThaiPhanLoai;
			tmp.NgayPhanLoai = _obj.NgayPhanLoai;
			tmp.IdPhanLoai = _obj.IdPhanLoai;
			tmp.IdLoaiDoiTuong = _obj.IdLoaiDoiTuong;
			tmp.NoiDung = _obj.NoiDung;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqPhanLoaiDoiTuongEntity obj)
		{
			provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.IdDoiTuong == IdDoiTuong
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThaiPhanLoai(string TrangThaiPhanLoai)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.TrangThaiPhanLoai == TrangThaiPhanLoai
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayPhanLoai(DateTime NgayPhanLoai)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.NgayPhanLoai.Value == NgayPhanLoai
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdPhanLoai(Guid IdPhanLoai)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.IdPhanLoai.Value == IdPhanLoai
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.IdLoaiDoiTuong.Value == IdLoaiDoiTuong
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiDung(string NoiDung)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.NoiDung == NoiDung
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqPhanLoaiDoiTuongEntity ob = (LqPhanLoaiDoiTuongEntity)q.First<LqPhanLoaiDoiTuongEntity>();
            provider.GetTable<LqPhanLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqPhanLoaiDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqPhanLoaiDoiTuongEntity>();
		}

		public List<LqPhanLoaiDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.IdDoiTuong == IdDoiTuong
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByTrangThaiPhanLoai(string TrangThaiPhanLoai)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.TrangThaiPhanLoai == TrangThaiPhanLoai
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByNgayPhanLoai(DateTime NgayPhanLoai)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.NgayPhanLoai.Value == NgayPhanLoai
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByIdPhanLoai(Guid IdPhanLoai)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.IdPhanLoai.Value == IdPhanLoai
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.IdLoaiDoiTuong.Value == IdLoaiDoiTuong
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByNoiDung(string NoiDung)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.NoiDung == NoiDung
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		public List<LqPhanLoaiDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiDoiTuongEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqPhanLoaiDoiTuongEntity>();
		}
		
		
		

	}
}
